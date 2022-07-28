import * as yup from "yup";

const validations = yup.object({
    firstName: yup.string().required("First name is required."),
    lastName: yup.string().required("Last name is required."),
    email: yup.string().email().required("Email is required."),
    password: yup.string().min(6, "Password must be min 6 characters.").max(12, "Password must be max 12 characters.").required("Password is required."),
    repassword: yup.string().min(6, "Password must be min 6 characters.").max(12, "Password must be max 12 characters.").required("Re-Password is required.").oneOf([yup.ref("password")], "Password and Re-Password does not match.")
});

export default validations;