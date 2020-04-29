import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Card from '@material-ui/core/Card';
import CardActions from '@material-ui/core/CardActions';
import CardContent from '@material-ui/core/CardContent';
import Button from '@material-ui/core/Button';
import Typography from '@material-ui/core/Typography';
import Paper from '@material-ui/core/Paper';

const useStyles = makeStyles({
  root: {
    minWidth: 300,
  },
  title: {
    fontSize: 16,
  },
  pos: {
    marginBottom: 12,
  },
});

const DisplayData = ({data}) => {
  const classes = useStyles();
  return (
    <div class="displayData">
      {
        data.map(item=>{
          return(
            <Card className={classes.root}>
              <CardContent>
                {
                  Object.keys(item).map(key => {
                    if(key === "extra") {
                      return;
                    }
                    const content = item[key];
                    return (
                      <Typography className={classes.title} gutterBottom>
                        {content}
                      </Typography>
                    )
                  })
                }
              </CardContent>
            </Card>
          )
        })
      }
    </div>
  )

}

export default DisplayData;
