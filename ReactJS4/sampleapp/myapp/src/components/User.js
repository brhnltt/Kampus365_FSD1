import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";



export default function User() {

    const { id } = useParams();
    const [user, setUser] = useState({});

    useEffect(() => {
        // setTimeout(() => {
        fetch("https://jsonplaceholder.typicode.com/users/" + id)
            .then((res) => res.json())
            .then((data) => setUser({ name: data.name, username: data.username, email: data.email, street: data.address.street, suite: data.address.suite, company: data.company.name }));
        // }, 1000);
    }, [id]);

    return (
        <>
            <h1>User Details</h1>
            <hr />
            <div><b>name : </b>{user.name}</div>
            <div><b>username : </b>{user.username}</div>
            <div><b>email : </b>{user.email}</div>
            <div><b>address street : </b>{user.street}</div>
            <div><b>address suite : </b>{user.suite}</div>
            <div><b>company name : </b>{user.company}</div>
        </>
    );
}