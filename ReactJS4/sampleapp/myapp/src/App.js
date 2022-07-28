import { Routes, Route, Link, useMatch } from "react-router-dom";
import Home from "./components/Home";
import About from "./components/About";
import Users from "./components/Users";
import User from "./components/User";
import NoPage from "./components/NoPage";
import Register from "./components/Register";

export default function App() {
  return (
    <div className="container mt-3 mb-3">

      <div className="row">
        <div className="col text-end">
          <Link to="/" className={useMatch({ path: "", end: true }) ? "btn btn-primary me-3" : "btn btn-secondary me-3"}>Home</Link>
          <Link to="/about" className={useMatch({ path: "about", end: true }) ? "btn btn-primary me-3" : "btn btn-secondary me-3"}>About</Link>
          <Link to="/users" className={useMatch({ path: "users", end: true }) ? "btn btn-primary me-3" : "btn btn-secondary me-3"}>Users</Link>
          <Link to="/register" className={useMatch({ path: "register", end: true }) ? "btn btn-primary me-3" : "btn btn-secondary me-3"}>Register</Link>
        </div>
      </div>

      <Routes>
        <Route path='/' element={<Home />} />
        <Route path='about' element={<About />} />
        <Route path='register' element={<Register />} />
        <Route path='users' element={<Users />}>
          <Route path=':id' element={<User />} />
        </Route>
        {/* <Route path='user/:id' element={<User />} /> */}
        <Route path="*" element={<NoPage />} />
      </Routes>
    </div>
  );
}