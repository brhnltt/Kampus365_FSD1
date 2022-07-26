import { useState, useEffect } from "react";
import axios from "axios";
import { Form, Field, Formik } from "formik";

function UseFormik() {

    const [users, setUsers] = useState([]);
    const [isLoading, setIsLoading] = useState(true);

    useEffect(() => {

        // debugger;

        // setTimeout(() => {
        //     fetch("https://jsonplaceholder.typicode.com/users")
        //         .then((res) => res.json())
        //         .then((data) => setUsers(data))
        //         .catch((e) => console.log(e))
        //         .finally(() => { setIsLoading(false) })
        // }, 3000);

        axios("https://jsonplaceholder.typicode.com/users")
            .then((res) => setUsers(res.data))
            .catch((e) => console.log(e))
            .finally(() => { setIsLoading(false) })

    }, []);

    function addUser(user) {
        axios.post("https://jsonplaceholder.typicode.com/users", user)
            .then((res) => setUsers([...users, res.data]));
    }

    return (
        <>
            <div className="row">
                <div className="col">
                    <div>
                        <h1 className="display-3">Using Formik</h1>
                        <hr />
                    </div>
                </div>
            </div>

            <div className="row">
                <div className="col-8">
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
                <div className="col-4">
                    <h2 className="display-4">Add New User</h2>
                    <hr />
                    <Formik initialValues={{ name: "", username: "", email: "" }} onSubmit={(values) => addUser(values)}>
                        <Form>
                            <div className="form-group">
                                <label htmlFor="name" className="form-label">Name</label>
                                <Field type="text" name="name" id="name" className="form-control" placeholder="john doe" />
                            </div>
                            <div className="form-group mt-2">
                                <label htmlFor="username" className="form-label">Username</label>
                                <Field type="text" name="username" id="username" className="form-control" placeholder="john_doe" />
                            </div>
                            <div className="form-group mt-2">
                                <label htmlFor="email" className="form-label">Email</label>
                                <Field type="email" name="email" id="email" className="form-control" placeholder="john@doe.com" />
                            </div>
                            <div className="form-group mt-2 text-end">
                                <button type="submit" className="btn btn-primary btn-sm">
                                    <i className="fa fa-paper-plane me-2"></i>Add
                                </button>
                            </div>
                        </Form>
                    </Formik>
                </div>
            </div>
        </>
    );
}

export default UseFormik;