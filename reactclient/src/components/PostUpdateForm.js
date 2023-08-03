import React, { useState } from 'react'
import Constants from '../utilities/Constants'

export default function PostUpdateForm(props) {
    const initialFormData = Object.freeze({
        firstName: props.post.firstName,
        lastName: props.post.lastName,
        age: props.post.age,
        mobileNo: props.post.mobileNo,
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

        const postToUpdate = {
            postId: props.post.postId,
            firstName: formData.firstName,
            lastName: formData.lastName,
            age: formData.age,
            mobileNo: formData.mobileNo
        };

        const url = Constants.API_URL_UPDATE_POST;

        fetch(url, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(postToUpdate)
        })
            .then(response => response.json())
            .then(responseFromServer => {
                if(responseFromServer !== "Update successful.")
                {
                    throw new Error(responseFromServer);
                }
                console.log(responseFromServer);
                props.onPostUpdated(postToUpdate);
            })
            .catch((error) => {
                console.log(error);
                alert(error);
            });

    };

    return (
        <form className="w-100 px-5">
            <h1 className="mt-5">Updating the user named "{props.post.firstName}".</h1>

            <div className="mt-5">
                <label className="h3 form-label">First Name</label>
                <input value={formData.firstName} name="firstName" type="text" className="form-control" onChange={handleChange} />
            </div>

            <div className="mt-4">
                <label className="h3 form-label">Last Name</label>
                <input value={formData.lastName} name="lastName" type="text" className="form-control" onChange={handleChange} />
            </div>

            <div className="mt-4">
                <label className="h3 form-label">Age</label>
                <input value={formData.age} name="age" type="number" className="form-control" onChange={handleChange} />
            </div>

            <div className="mt-4">
                <label className="h3 form-label">Mobile No</label>
                <input value={formData.mobileNo} name="mobileNo" type="text" className="form-control" onChange={handleChange} />
            </div>

            <button onClick={handleSubmit} className="btn btn-dark btn-lg w-100 mt-5">Submit</button>
            <button onClick={() => props.onPostUpdated(null)} className="btn btn-secondary btn-lg w-100 mt-3">Cancel</button>
        </form>
    );
}