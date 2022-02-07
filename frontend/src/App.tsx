import React from 'react';
import logo from './logo.svg';
import './App.css';
import { useVisits } from './entities/visits/visits.hook';

function App() {
  const [visitsCount, isLoading, increment] = useVisits();

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo"/>
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React with me
        </a>
      </header>
      <main>
        {isLoading ? <span>...Loading</span> : <span>Number of visits is {visitsCount}</span>}
        <br/>
        <button onClick={() => increment()}>Increment</button>
      </main>
    </div>
  );
}

export default App;
