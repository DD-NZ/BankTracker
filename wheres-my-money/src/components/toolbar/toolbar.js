import React, {useState} from 'react';
import List from '@material-ui/core/List';
import DatePicker from './widgets/datePicker';
import SelectWidget from './widgets/select';
import { makeStyles } from '@material-ui/core/styles';

const useStyles = makeStyles((theme) => ({
  formControl: {
    margin: theme.spacing(2),
    minWidth: 240,
    maxWidth: 240,
  },
}));


const ToolbarContent = () => {
  const classes = useStyles();
  const [startDate, setStartDate] = useState(undefined);
  const [endDate, setEndDate] = useState(undefined);

  const startDateChangeHandler = date => {
    setStartDate(date);
  }

  const endDateChangeHandler = date => {
    setEndDate(date);
  }

  return (
    <List style={{textAlign:"center"}}>
      <DatePicker label="Start Date" value={startDate} classes={classes} onChangeHandler={startDateChangeHandler}/>
      <DatePicker label="End Date" value={endDate} classes={classes} onChangeHandler={endDateChangeHandler}/>
      <SelectWidget classes={classes}/>
    </List>
  );
}

export default ToolbarContent;
