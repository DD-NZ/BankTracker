import React, {useEffect} from 'react';
import DateFnsUtils from '@date-io/date-fns';
import { makeStyles } from '@material-ui/core/styles';
import FormControl from '@material-ui/core/FormControl';
import {
  MuiPickersUtilsProvider,
  KeyboardDatePicker,
} from '@material-ui/pickers';



const DatePicker = ({classes, label, value, onChangeHandler}) => {

  const handleDateChange = (date) => {
    onChangeHandler(date);
  };

  return (
    <div class="listItem">
    <FormControl variant="outlined" className={classes.formControl}>
      <MuiPickersUtilsProvider utils={DateFnsUtils} >
          <KeyboardDatePicker
            className={classes.datePicker}
            disableToolbar
            variant="inline"
            format="dd-MMM-yyyy"
            margin="normal"
            id="date-picker-inline"
            label={label}
            value={value}
            onChange={handleDateChange}
            KeyboardButtonProps={{
              'aria-label': 'change date',
            }}
          />
      </MuiPickersUtilsProvider>
    </FormControl>
    </div>
  );
}

export default  DatePicker;
