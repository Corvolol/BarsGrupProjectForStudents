import React, { Component } from 'react';
import { ListGroup, ListGroupItem } from 'reactstrap';

export class Tag extends Component {
    static displayName = Tag.name;

    render() {
        return (
            <body>
                <h3>Тег1</h3> <br />
                <ListGroup flush>
                    <ListGroupItem>
                        <h4>Билеты</h4>
                        <p>Информация по билетам</p>
                    </ListGroupItem>

                    <ListGroupItem>
                        <h4>Материалы</h4>
                        <p>Информация по материалам</p>
                    </ListGroupItem>
                </ListGroup>

            </body>
        );
    }
}
