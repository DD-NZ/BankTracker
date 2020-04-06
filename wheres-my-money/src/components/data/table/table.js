import React, {useEffect, useState} from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableContainer from '@material-ui/core/TableContainer';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import Paper from '@material-ui/core/Paper';
import TablePagination from '@material-ui/core/TablePagination';
import Checkbox from '@material-ui/core/Checkbox';

const useStyles = makeStyles({
  root: {
    width: '100%',
  },
  container: {
    maxHeight: 440,
  },
});

const maxLengthReducer = (maxLength, currentValue) => currentValue.length > maxLength ? currentValue.length : maxLength ;

const StatementTable = ({data}) => {
  const [selected, setSelected]=useState([]);
  const [tableData, setTableData]=useState([])
  const classes = useStyles();
  const maxLength = data.reduce(maxLengthReducer, -1);

  useEffect(()=>{
    const selectedData=[]
    data.forEach((row, index) => {
      if(row.length<maxLength) {
        selectedData.push(index);
      }
    });

    const modifiedData = data.map((row,index) =>{
      if(row.length<maxLength) {
        let count = row.length;
        while(count<maxLength){
          row.push(undefined);
          count++;
        }
      }
      return {
        index,
        row
      };
    })
    setSelected(selectedData);
    setTableData(modifiedData)
  },[])


  const isChecked= row => (selected.includes(row.index));

  return (
    <div class="table">
    <Paper className={classes.root}>
      <TableContainer className={classes.container}>
        <Table stickyHeader size="small" aria-label="a dense table">
          <TableBody>
            {tableData.map((row) => (
              <TableRow
                role="checkbox"
                selected={isChecked(row)}
              >
              <TableCell padding="checkbox">
                <Checkbox
                  checked={isChecked(row)}
                />
              </TableCell>
              {
                row.row.map(cell => ( <
                  TableCell align = "right" > {
                    cell
                  } < /TableCell>
                ))
              }
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </Paper>
    </div>
  );
}

export default StatementTable;
