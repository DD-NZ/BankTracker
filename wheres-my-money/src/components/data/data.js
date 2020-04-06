import React, {useState} from 'react';
import Load from './load/load';
import StatementTable from './table/table';

const Data = () => {

  const [data, setData] = useState();

  const onDataLoad = loadedData => {
    setData(loadedData.data);
  };

  return (
    <div class="data">
      {data===undefined ? <Load onLoadHandler={onDataLoad}/> : <StatementTable data={data}/> }
    </div>
  );
}

export default Data;
