import './App.css';
// import UsingUseEffect from "./components/UsingUseEffect";
// import UsingFetch from "./components/UsingFetch";
// import UsingAxios from "./components/UsingAxios";
import UseFormik from "./components/UseFormik";
import { useState } from "react";

function App() {

  // const [showUsingUseEffect, setShowUsingUseEffect] = useState(false);

  return (
    <>
      <div className="container">
        <div className='p-3'>
          {/* {showUsingUseEffect && <UsingUseEffect />}
        <button onClick={() => setShowUsingUseEffect(!showUsingUseEffect)}>Show or Hide UsingUseEffect Component</button> */}

          {/* <UsingFetch /> */}
          {/* <UsingAxios /> */}
          <UseFormik />
        </div>
      </div>
    </>
  );
}

export default App;
