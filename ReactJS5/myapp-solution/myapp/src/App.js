import './App.css';
import Users from "./components/Users";
import Todo from "./components/Todo";

function App() {

  const users = ["John Doe", "Bruce Willis", "Nicolas Cage"];
  

  return (
    <div className="App">
      <header className="App-header">
        {/* <Users data={users} /> */}
        <Todo />
      </header>
    </div>
  );
}

export default App; 