import React, { useState } from 'react'
import Constants from '../utilities/Constants'

export default function PostCreateForm(props) {
    const initialFormData = Object.freeze({
        firstName: "",
        lastName: "",
        age: 0,
        mobileNo: "", 
    });

    const [formData, setFormData] = useState(initialFormData);

    const handleChange = (e) => {
        setFormData({
            ...formData,
            [e.target.name]: e.target.value,
        });
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        if(formData.age === undefined || formData.age===null)
        {
            alert("age can't be empty");
            return;
        }

        const postToCreate = {
            postId: 0,
            firstName: formData.firstName,
            lastName: formData.lastName,
            age: formData.age,
            mobileNo: formData.mobileNo
        };

        const url = Constants.API_URL_CREATE_POST;

        fetch(url, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(postToCreate)
        })
            .then(response=>response.json())
            .then(responseFromServer => {
                if(responseFromServer !== "Create successful.")
                {
                    throw new Error(responseFromServer);
                }
                console.log(responseFromServer);
                props.onPostCreated(postToCreate);
            })
            .catch((error) => {
                console.log(error);
                alert(error);
            });

    };

    return (
        <form className="w-100 px-5">
            <h1 className="mt-5">Add new User</h1>

            <div className="mt-5">
                <label className="h3 form-label">First Name</label>
                <input value={formData.firstName} name="firstName" type="text" placeholder='enter firstname without any space and not more than 20 letters' className="form-control" onChange={handleChange} />
            </div>

            <div className="mt-4">
                <label className="h3 form-label">Last Name</label>
                <input value={formData.lastName} name="lastName" type="text" placeholder='enter lastname without any space and not more than 20 letters'className="form-control" onChange={handleChange} />
            </div>

            <div className="mt-4">
                <label className="h3 form-label">Age</label>
                <input value={formData.age} name="age" type="number" placeholder='enter valid age' className="form-control" onChange={handleChange} />
            </div>

            <div className="mt-4">
                <label className="h3 form-label">Mobile No</label>
                <input value={formData.mobileNo} name="mobileNo" type="text" placeholder='enter mobile no with exactly 10 digits' className="form-control" onChange={handleChange} />
            </div>

            <button onClick={handleSubmit} className="btn btn-dark btn-lg w-100 mt-5">Submit</button>
            <button onClick={() => props.onPostCreated(null)} className="btn btn-secondary btn-lg w-100 mt-3">Cancel</button>
        </form>
    );
}