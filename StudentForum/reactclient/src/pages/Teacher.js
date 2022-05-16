import React, { useState } from 'react';
import { ListGroup, ListGroupItem } from 'reactstrap';
import constants from './Constants';

export default function Teacher() {
    const [teacher, setTeacher] = useState([]);

    function getTeacher() {
        const url = constants.API_URL_TEACHER;

        fetch(url, {
            method: 'GET'
        })
            .then(response => response.json())
            .then(teacherFromServer => {
                setTeacher(teacherFromServer);
            })
            .catch((error) => {
                console.log(error);
                alert(error);
            });
    }

    return (
        <body>
            {getTeacher()}
            {teacher.map((teacher) => (
                <>
                    <center><h4>Информация об учителе</h4></center><br />
                    <h4>{teacher.Name}</h4><br />
                    <p>Кафедра {teacher.Cafedra}</p><br />
                    <p>Предметы: {teacher.Tags.map((tag) => (tag.Name))}</p><br />
                    <h5>Отзывы:</h5><br />
                    <ListGroup flush> {
                        teacher.Reviews.map((review) =>
                            <ListGroupItem>
                                <p>{review.User.NickName}</p><br />
                                <p>{review.Value}</p>
                                <p>{review.Date}</p>
                            </ListGroupItem>
                        )}
                    </ListGroup>
                </>
            ))}
        </body>
    );
}
