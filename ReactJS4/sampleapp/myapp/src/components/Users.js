import { useEffect, useState } from "react";
import { Link, Outlet } from "react-router-dom";


export default function Users() {
    
    const [users, setUsers] = useState([]);

    useEffect(() => {
        fetch("https://jsonplaceholder.typicode.com/users")
            .then((res) => res.json())
            .then((data) => setUsers(data));
    }, []);


    return (
        <>
            <div className="row">
                <div className="col">
                    <h1>Users Page</h1>
                    <hr />
                    <ul className="list-group mt-3">
                        {
                            users.map((user) => {
                                return <li key={user.id} className="list-group-item">
                                    <Link to={`/users/${user.id}`}>{user.name}</Link>
                                </li>
                            })
                        }
                    </ul>
                </div>
                <div className="col">
                    <Outlet />
                </div>
            </div>
        </>
    );
}