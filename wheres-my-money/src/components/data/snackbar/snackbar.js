import React, {useEffect} from 'react';
import Button from '@material-ui/core/Button';
import Snackbar from '@material-ui/core/Snackbar';
import MuiAlert from '@material-ui/lab/Alert';
import { makeStyles } from '@material-ui/core/styles';

const useStyles = makeStyles((theme) => ({
  root: {
    width: '100%',
    '& > * + *': {
      marginTop: theme.spacing(2),
    },
  },
}));

const defaultAlertProps = {
    severity:"error"
}

const defaultSnackBarProps = {
  autoHideDuration:5000,
  elevation:6,
}

const CustomSnackbar = ({open, snackbarprops, alertProps}) => {
  const classes = useStyles();
  const [isOpen, setIsOpen] = React.useState();

  useEffect(() => {
    setIsOpen(open)
  },[open])

  const sbProps = {
    ...defaultSnackBarProps,
    ...snackbarprops,
  }

  const aProps = {
    ...defaultAlertProps,
    ...alertProps,
  }

  const handleClose = (event, reason) => {
    if (reason === 'clickaway') {
      return;
    }
    setIsOpen(false);
  };

  return (
    <div className={classes.root}>
      <Snackbar open={isOpen} {...sbProps}>
        <MuiAlert variant="filled" {...aProps} >
          {aProps.message}
        </MuiAlert>
      </Snackbar>
    </div>
  );
}

export default CustomSnackbar;
