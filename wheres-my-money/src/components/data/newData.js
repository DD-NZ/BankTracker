import React, {useState} from 'react';
import Load from './load/load';
import CheckboxTable from './table/checkboxTable';
import SelectTable from './table/selectTable';
import Button from '@material-ui/core/Button';
import CustomSnackbar from './snackbar/snackbar'

const modifyCSV = (data) => {
  const maxLengthReducer = (maxLength, currentValue) => currentValue.length > maxLength ? currentValue.length : maxLength ;
  const maxLength = data.reduce(maxLengthReducer, -1);
  return data.map((row,index) =>{
    let selected = false;
    if(row.length<maxLength) {
      selected=true;
      let count = row.length;
      while(count<maxLength){
        row.push(undefined);
        count++;
      }
    }
    return {
      index,
      selected,
      row
    };
  })
}

const checkHeaderValid = (headerData) => {
  const selectedItems = headerData.filter(item=> item!=="");
  if(selectedItems.length === 4){
      return true;
  }
  return false;
}

const createObject=(headers, body) =>{
  const rowReducer = (accumulator, currentValue, index) => {
    const header = headers[index];
    if (header==="") {
      accumulator.extra.push(currentValue);
    } else {
      accumulator[header] = currentValue
    }
    return accumulator;
  }

  return body.map(row=>{
    const structure = {
      extra:[]
    }
    return row.row.reduce(rowReducer,structure);
  });
};

const NewData = ({size, newDataHandler}) => {
  const [workFlowState, setWorkFlowState] = useState("load");
  const [loadedData, setLoadedData] = useState();
  const [trimmedData, setTrimmedData] = useState();
  const [headerData, setHeaderData] = useState();
  const [error, setError]=useState(false);

  const onLoadHandler = data => {
    setLoadedData(modifyCSV(data.data));
    setWorkFlowState("trim")
  };

  const onTrimHandler = data => {
    setTrimmedData(data.filter(row=> !row.selected));
  };

  const onHeaderHandler = data => {
    setHeaderData(data);
  };

  const onFinishHandler = () => {

    if(checkHeaderValid(headerData)){
      newDataHandler(createObject(headerData,trimmedData));
    } else {
    setError(true)
    }
  };

  const onPreviousHandler = () => {
    setWorkFlowState("trim");
  };

  if (workFlowState === "load") {
    return (
      <div class="newData">
        <Load onLoadHandler={onLoadHandler}/>
      </div>
    );
  } else if (workFlowState === "trim") {
    return(
        <div class="newData">
          <div class="table">
            <CheckboxTable
              data={loadedData}
              onChangeHandler={onTrimHandler}
              height={size.height*0.85}
            />
            <div class="floatRight">
              <Button
                variant="contained"
                onClick={() => setWorkFlowState("header")}
              >
                Next
              </Button>
            </div>
          </div>
        </div>
        )
      }
  else {
    return (
      <div class="newData">
        <div class="table">
          <SelectTable
            data={trimmedData}
            onChangeHandler={onHeaderHandler}
            height={size.height*0.85}
          />
          <div class="floatRight">
            <Button
              variant="contained"
              onClick={onFinishHandler}
            >
              Finish
            </Button>
          </div>
          <div class="floatLeft">
            <Button
              variant="contained"
              onClick={onPreviousHandler}
            >
              Previous
            </Button>
          </div>
          <CustomSnackbar open={error} alertProps={{severity:"error", message:"Please select one of each Header"}}/>
        </div>
      </div>
    )
  }
}

export default NewData;
