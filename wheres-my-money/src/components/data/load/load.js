import React, {useRef} from 'react';
import { readString } from 'react-papaparse'
import Button from '@material-ui/core/Button';

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


  const inputOnChange = (e) => {
    if (e.target.files && e.target.files.length > 0) {
      var reader = new FileReader();
      reader.onload = (reader => {
        return () => {
          onLoadHandler(readString(reader.result));
        }
      })(reader);
      const text = reader.readAsText(e.target.files[0])
    }
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
      <div class='content'>
        <input
         type='file'
         ref={inputRef}
         style={{display: 'none'}}
         onChange={inputOnChange}
        />
        <div class='row'>
          <Button
          onClick={onClick}
          >
            Click Here To Load File
          </Button>
        </div>
        <div class='rowCenter'>
        <i class="fas fa-file-upload fa-10x"></i>
        </div>
        <div class='rowCenter'>
        <p class="noselect">Drop File Here</p>
        </div>
      </div>
      </div>
    </div>
  );
}

export default Load;
