import React, { useState } from 'react';
import { ListGroup, ListGroupItem } from 'reactstrap';
import constants from './Constants';

export function Teachers() {
    
    const [teachers, setTeachers] = useState([]);

    function getTeachers() {
        const url = constants.API_URL_GET_ALL_TEACHERS;
        
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
            {teachers.map((id, name) => (
                <ListGroup flush>
                    <ListGroupItem
                        action
                        href="/teacher"
                        tag="a"
                    >
                        <h4>{name}</h4>
                    </ListGroupItem>
                </ListGroup>
            ))}
        </body>
    );
}

/*

*/