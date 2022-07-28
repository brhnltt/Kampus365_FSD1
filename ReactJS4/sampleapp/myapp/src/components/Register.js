import { Link } from "react-router-dom";
import { useFormik } from "formik";
import validations from "./RegisterValidations";

export default function Register() {

    const { handleSubmit, handleChange, values, errors } = useFormik({
        initialValues: {
            firstName: "",
            lastName: "",
            email: "",
            password: "",
            repassword: ""
        },
        onSubmit: values => {
            console.log(values);
        },
        validationSchema: validations
    });

    return (
        <>
            <div className="row mt-5">
                <div className="col-4 offset-4">
                    <h1 className="display-4 text-center">Register</h1>
                    <hr />

                    <form onSubmit={handleSubmit}>
                        <div className="form-group mt-2">
                            <label className="form-label">First Name</label>
                            <input id="firstName" name="firstName" type="text" className="form-control" placeholder="John" onChange={handleChange} value={values.firstName} />
                            <div className="badge bg-danger small text-end">{errors.firstName}</div>
                        </div>

                        <div className="form-group mt-2">
                            <label className="form-label">Last Name</label>
                            <input id="lastName" name="lastName" type="text" className="form-control" placeholder="Doe" onChange={handleChange} value={values.lastName} />
                            <div className="badge bg-danger small text-end">{errors.lastName}</div>
                        </div>

                        <div className="form-group mt-2">
                            <label className="form-label">E-mail Address</label>
                            <input id="email" name="email" type="email" className="form-control" placeholder="john@doe.com" onChange={handleChange} value={values.email} />
                            <div className="badge bg-danger smalltext-end">{errors.email}</div>
                        </div>

                        <div className="form-group mt-2">
                            <label className="form-label">Passwrod</label>
                            <input id="password" name="password" type="password" className="form-control" placeholder="123123" onChange={handleChange} value={values.password} />
                            <div className="badge bg-danger small text-end">{errors.password}</div>
                        </div>

                        <div className="form-group mt-2">
                            <label className="form-label">Re-Password</label>
                            <input id="repassword" name="repassword" type="password" className="form-control" placeholder="123123" onChange={handleChange} value={values.repassword} />
                            <div className="badge bg-danger small text-end">{errors.repassword}</div>
                        </div>

                        <div className="form-group mt-2">
                            <button type="submit" className="btn btn-primary btn-block">Send</button>
                            <Link to="/" className="btn btn-secondary ms-2">Go to Home Page!</Link>
                        </div>
                    </form>
                </div>
            </div>
        </>
    );
}