import { Link } from "react-router-dom";

export default function NoPage() {
    return (
        <>
            <div className="row mt-5">
                <div className="col text-center">
                    <h1 className="display-4">Page Not Found</h1>
                    <hr />
                    <p className="my-2">Lorem ipsum dolor sit amet consectetur adipisicing elit. Numquam maxime assumenda, voluptatem architecto nisi repellendus ipsa quos fugiat facilis repudiandae modi nam asperiores veritatis dolorem expedita laborum tempore odio culpa.</p>
                    <Link to="/" className="btn btn-primary">Go to Home Page!</Link>
                </div>
            </div>
        </>
    );
}