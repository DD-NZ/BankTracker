import React, {useRef, useEffect, useState} from 'react';
import NewData from './newData'
import DisplayData from './displayData'
import Toolbar from '../toolbar/toolbar'


const Data = ({}) => {
  const ref = useRef();
  const [size, setSize] = useState({});
  const [data, setData] = useState();


  useEffect(() => {
    fetch("http://localhost:3000/data.json")
      .then(res => {
        return res.json()})
      .then(results => {
        setData(results);
      })
  }, [])

  useEffect(()=>{
    setSize({
      height:  window.innerHeight-100,
      width: window.innerWidth
    })
  },[])

  const newDataHandler = (newData) => {
    console.log(JSON.stringify(newData));
    setData(newData);
  }

  const props = {
    size,
    newDataHandler,
  }

  const width ="100%";

  return (
    <div style={{width:width, height:size.height}} class="data">
        {
          data
          ? (
            <div class="dataContent" ref={ref}>
              <DisplayData data={data}/>
            </div>
          )
          : (
            <div class="dataContent" ref={ref}>
              <NewData {...props}/>
            </div>
          )
        }
    </div>
  );
}

export default Data;
