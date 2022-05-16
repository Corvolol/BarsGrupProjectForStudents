import React, { Component, useState } from 'react';
import { ListGroup, ListGroupItem } from 'reactstrap';
import Constants from './Constants';


export default function Teachers() {
    const [teachers, setTeachers] = useState([]);

    function getTeachers() {
        const url = Constants.API_URL_GET_ALL_TEACHERS;
        console.log(url);
        fetch(url, {

            method: 'GET'
        })
            .then(response => response.json())
            .then(teachersFromServer => {
                setTeachers(teachersFromServer);
            })
            .catch((error) => {
                console.log(error);
                alert(error);
            });
    }

    return (
        <body>
            {getTeachers()}
            {teachers.map((teacher) => (
                <ListGroup flush>
                    <ListGroupItem
                        action
                        href="/teacher"
                        tag="a"
                    >
                        <h4>{teacher.name}</h4>
                    </ListGroupItem>
                </ListGroup>
            ))}
        </body>
    );
}

