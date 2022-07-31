import User from "./User";

export default function Users({ data }) {
    return (
        <>
            <h1>Users</h1>
            <ul>
                {
                    data.map((item, i) => <User item={item} />)
                }
            </ul>
        </>
    );
}