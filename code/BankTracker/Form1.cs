using System;
using System.IO;
using System.Collections;
using System.Security;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace BankTracker
{
    public partial class Form1 : Form
    {

        //All transactions loaded
        List<Transaction> allTransactions = new List<Transaction>();
        //the first date to filter from
        DateTime from = new DateTime(2100, 01, 01);
        //the last date to filter from
        DateTime to = new DateTime(1900, 01, 01);
        //search string to filter from
        String search = "";
        //direction to show dates, A = ascending, D = descending
        String direction = "A";

        //Keeping a track of if we are showing stats or displaying transactions
        Boolean showingStats = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //On load button click we open up a file chooser
            OpenFileDialog fileChooser = new OpenFileDialog();
            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(fileChooser.FileName);
                    if (createTransactions(sr))
                    {
                        mainpage.BringToFront();
                        //adds all the transactions to view
                        addTransactionsToPanel(allTransactions);
                        //initialises the date picker, and sets the max and min options for both.
                        fromDate.Value = from;
                        toDate.Value = to;

                        fromDate.MinDate = from;
                        fromDate.MaxDate = to;

                        toDate.MaxDate = to;
                        toDate.MinDate = from;
                    }
                    else
                    {

                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        //adds all the transactions to view
        private void addTransactionsToPanel(List<Transaction> transactions)
        {
            int total = transactions.Count;
            //loading bar increments
            double interval = total / 10;
            if (interval==0)
            {
                interval = 1;
            }
            int count = 0;

            //while loading transactions bring loading panel to front
            loadingProgress.Value = 0;
            loadingPanel.BringToFront();

            //clear the panel
            if (displayPanel.Controls.Count > 0)
            {
                displayPanel.Controls.Clear();
            }

            //create a text box for each transaction
            foreach (Transaction t in transactions)
            {
                if ((count%interval)==0)
                {
                    loadingProgress.PerformStep();
                }
                RichTextBox textBox = new RichTextBox();
                displayPanel.Controls.Add(textBox);

                textBox.Width = textBox.Parent.Width - 50;
                textBox.Margin = new Padding(10, 10, 10, 10);
                textBox.BackColor = Color.FromArgb(169, 169, 169);
                textBox.ForeColor = Color.White;
                textBox.Font = new Font("Arial", 16, FontStyle.Bold);
                textBox.BorderStyle = BorderStyle.None;
                textBox.Text = t.toString();
                textBox.ReadOnly = true;
                count++;
            }
            loadingPanel.SendToBack();

        }

        //populates the allTransactions list from the file.
        private Boolean createTransactions(StreamReader sr)
        {
            try
            {
                int lineNum = 0;
                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();
                    //All lines up to line 8 are not needed.
                    if (lineNum >= 8)
                    {
                        //split by , as its a csv file.
                        String[] split = line.Split(',');
                        //First split is the date, check if it is a current max or min date,
                        //if so update max or min date
                        DateTime dt = Convert.ToDateTime(split[0]);
                        if (dt.CompareTo(from) < 0)
                        {
                            from = dt;
                        }
                        if (dt.CompareTo(to) > 0)
                        {
                            to = dt;
                        }
                        //second split is the transaction id
                        int id = int.Parse(split[1]);
                        //third split is the type of transaction
                        String transType = split[2];
                        //fourth split is not needed and fith split is the payee.
                        String payee = split[4];

                        //Commas occur within a payee name and there for the previous split by
                        // comma will split up the payee name into multiple sections.
                        //this code combines them back togeher.
                        int numCommas = 0;
                        if (payee.Contains("\""))
                        {
                            Boolean foundEnd = false;
                            while (foundEnd != true)
                            {
                                numCommas++;
                                String next = split[4 + numCommas];
                                payee += ("," + next);
                                if (next.Contains("\""))
                                {
                                    foundEnd = true;
                                }
                            }
                        }

                        //following code is for getting the cost of the transaction
                        //if there are no cents it needs to be parsed as an int,
                        //if there are cents it needs to be parsed as a  double.
                        double amount = 0;
                        if (split[6 + numCommas].Contains("."))
                        {
                            amount = Math.Abs(double.Parse(split[6 + numCommas]));
                        }
                        else
                        {
                            amount = Math.Abs(int.Parse(split[6 + numCommas]));
                        }

                        //only take eftops CARD or FC transactions, this is all that is needed.
                        String memo = split[5 + numCommas];
                        if (memo.StartsWith("EFTPOS") || memo.StartsWith("CARD") || memo.StartsWith("FC"))
                        {
                            allTransactions.Add(new Transaction(dt, id, transType, payee, amount));
                        }

                    }
                    lineNum++;
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            search = ((TextBox)sender).Text;
            addTransactionsToPanel(filter());
        }

        //filters allTransactions and returns a list of transactions that meet the title, date
        //and directions
        private List<Transaction> filter()
        {
            List<Transaction> filteredTransactions = new List<Transaction>();
            foreach (Transaction t in allTransactions)
            {
                DateTime d = t.getDate();
                if (d.CompareTo(from) >= 0 && d.CompareTo(to) <= 0)
                {
                    if (search.Equals(""))
                    {
                        filteredTransactions.Add(t);
                    }
                    else if (t.getPayee().ToUpper().Contains(search.ToUpper()))
                    {
                        Console.WriteLine(t.getPayee() + " Contains: " + search);
                        filteredTransactions.Add(t);
                    }

                }
            }
            if (descendingButton.Checked==true)
            {
                filteredTransactions.Reverse();
            }
            return filteredTransactions;
        }


        // when filter buttons are changed, the updated transactions are displayed.
        private void FromDate_ValueChanged(object sender, EventArgs e)
        {
            from = ((DateTimePicker)sender).Value;
            addTransactionsToPanel(filter());
        }

        private void ToDate_ValueChanged(object sender, EventArgs e)
        {
            to = ((DateTimePicker)sender).Value;
            addTransactionsToPanel(filter());
        }

        private void AscendingButton_CheckedChanged(object sender, EventArgs e)
        {
            addTransactionsToPanel(filter());
        }

        private void DescendingButton_CheckedChanged(object sender, EventArgs e)
        {
            addTransactionsToPanel(filter());
        }


        //When the stats button is clicked, it displays the stats for the 
        //filtered transactions
        private void statsButton_Click(object sender, EventArgs e)
        {
            if (showingStats)
            {
                showingStats = false;
                Statspanel.SendToBack();
            }
            else
            {
                showingStats = true;
                Statspanel.BringToFront();
                RichTextBox b = statsText;
                b.Text = getStats();
            }
        }

        private String getStats()
        {
            List<Transaction> transactions = filter();
            double amount = 0;
            foreach (Transaction t in transactions)
            {
                amount += t.getAmount();
            }
            String s = "Search for: " + search + "\nBetween " + from.ToShortDateString()+ " and " + to.ToShortDateString() + "\nYou Spent: $"+amount;
            return s;
        }
    }
}
