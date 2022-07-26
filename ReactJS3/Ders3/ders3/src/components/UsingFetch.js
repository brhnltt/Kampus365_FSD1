import { useState, useEffect } from "react";

function UsingFetch() {

    const [users, setUsers] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const [user, setUser] = useState({ name: "", username: "", email: "" });

    useEffect(() => {

        // debugger;

        // setTimeout(() => {
        //     fetch("https://jsonplaceholder.typicode.com/users")
        //         .then((res) => res.json())
        //         .then((data) => setUsers(data))
        //         .catch((e) => console.log(e))
        //         .finally(() => { setIsLoading(false) })
        // }, 3000);

        fetch("https://jsonplaceholder.typicode.com/users")
            .then((res) => res.json())
            .then((data) => setUsers(data))
            .catch((e) => console.log(e))
            .finally(() => { setIsLoading(false) })

    }, []);

    return (
        <>
            <div className="row">
                <div className="col">
                    <div>
                        <h1 className="display-3">Using Fetch</h1>
                        <hr />
                    </div>
                </div>
            </div>

            <div className="row">
                <div className="col">
                    <h2 className="display-4">Users</h2>
                    <hr />

                    {
                        isLoading &&
                        <div className="alert alert-info">
                            <i className="fa fa-sync fa-spin me-2"></i><span>veriler yükleniyor..</span>
                        </div>
                    }

                    <ul className="list-group">
                        {
                            users.map((user) => {
                                return <li className="list-group-item" key={user.id}>
                                    <i className="fa fa-user me-2"></i>{user.name} ({user.username}) <a className="btn btn-primary btn-sm" href={`mailto:${user.email}`}>Mail gönder</a>
                                </li>
                            })
                        }
                    </ul>
                </div>
                <div className="col">
                    <h2 className="display-4">Add New User</h2>
                    <hr />
                    <div className="form-group">
                        <label className="form-label">Name</label>
                        <input type="text" className="form-control" placeholder="john doe"
                            onChange={(e) => setUser({ ...user, name: e.target.value })} />
                    </div>
                    <div className="form-group mt-2">
                        <label className="form-label">Username</label>
                        <input type="text" className="form-control" placeholder="john_doe"
                            onChange={(e) => setUser({ ...user, username: e.target.value })}/>
                    </div>
                    <div className="form-group mt-2">
                        <label className="form-label">Email</label>
                        <input type="email" className="form-control" placeholder="john@doe.com"
                            onChange={(e) => setUser({ ...user, email: e.target.value })}/>
                    </div>
                    <div className="form-group mt-2 text-end">
                        <button className="btn btn-primary btn-sm" onClick={() => setUsers([...users, user])}>
                            <i className="fa fa-paper-plane me-2"></i>Add
                        </button>
                    </div>
                </div>
            </div>
        </>
    );
}

export default UsingFetch;