import pic from './quoter.png';
import './App.css';
import FileUpload from './FileUpload.js'

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={pic} className="App-logo" alt="logo" />
        <p id="title">
          Let's quote your CAD Drawing!
        </p>
        <h1 className="App-header">
         SolidWorks File Uploader
         <FileUpload />
       </h1>
        {/* <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Hello
        </a> */}
      </header>
    </div>
  );
}

export default App;

// import React from 'react';
// import FileUpload from './components/FileUpload';

// function App() {
//   return (
//     <div className="App">
//       <header className="App-header">
//         <h1>SolidWorks File Uploader</h1>
//         <FileUpload />
//       </header>
//     </div>
//   );
// }

// export default App;
