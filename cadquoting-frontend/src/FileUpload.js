import React, { useState } from 'react';
import axios from 'axios';

const FileUpload = () => {
  const [file, setFile] = useState(null);
  const [message, setMessage] = useState('');

  const onFileChange = (e) => {
    setFile(e.target.files[0]);
  };

  const onSubmit = async (e) => {
    e.preventDefault();
    const formData = new FormData();
    formData.append('file', file);

    try {
      const res = await axios.post('http://localhost:5000/upload', formData, {
        headers: {
          'Content-Type': 'multipart/form-data'
        }
      });
      setMessage(res.data);
    } catch (err) {
      if (err.response) {
        setMessage(err.response.data.error);
      } else {
        setMessage('An error occurred while uploading the file');
      }
    }
  };

  return (
    <div>
      <form onSubmit={onSubmit}>
        <div>
          <input type="file" onChange={onFileChange} />
        </div>
        <div>
          <button type="submit">Upload</button>
        </div>
      </form>
      {message && <pre>{JSON.stringify(message, null, 2)}</pre>}
    </div>
  );
};

export default FileUpload;