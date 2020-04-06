import React, {useRef} from 'react';
import { readString } from 'react-papaparse'
import { Button } from 'semantic-ui-react'

const Load = ({onLoadHandler}) => {
  const inputRef = useRef()

  const handleDragEnter = e => {
    e.preventDefault();
    e.stopPropagation();
  };
  const handleDragLeave = e => {
    e.preventDefault();
    e.stopPropagation();
  };
  const handleDragOver = e => {
    e.preventDefault();
    e.stopPropagation();
  };
  const handleDrop = e => {
    e.preventDefault();
    e.stopPropagation();
    if (e.dataTransfer.files && e.dataTransfer.files.length > 0) {
      var reader = new FileReader();
      reader.onload = (reader =>
        {
            return () =>
            {
              onLoadHandler(readString(reader.result));
            }
        })(reader);
      const text = reader.readAsText(e.dataTransfer.files[0])
    }
  };


  const inputOnChange = () => {

  };

  const onClick = () => {
    inputRef.current.click();
  };

  const onDrop = (event) => {
    console.log("yeet");
  }

  return (
    <div class="loadContainer">
      <div
        class="fileDropArea"
        onDrop={e => handleDrop(e)}
        onDragOver={e => handleDragOver(e)}
        onDragEnter={e => handleDragEnter(e)}
        onDragLeave={e => handleDragLeave(e)}
      >
        <input
         type='file'
         ref={inputRef}
         style={{display: 'none'}}
         onChange={inputOnChange}
        />
        <Button
        onClick={onClick}
        >
          Load File
        </Button>
        <p class="noselect">Drop File Here</p>
      </div>
    </div>
  );
}

export default Load;
