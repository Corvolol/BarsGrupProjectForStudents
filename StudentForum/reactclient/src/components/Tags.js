import React, { Component } from 'react';
import { ListGroup, ListGroupItem } from 'reactstrap';

export class Tags extends Component {
    static displayName = Tags.name;

    render() {
        return (
            <body>
                <h3>Все теги</h3> <br />
                <ListGroup flush>
                    <ListGroupItem
                        action
                        href="/tag"
                        tag="a"
                    >
                    <h4>Тег 1</h4>
                    </ListGroupItem>

                    <ListGroupItem
                        action
                        href="/tag"
                        tag="a"
                    >
                        <h4>Тег 2</h4>
                    </ListGroupItem>

                    <ListGroupItem
                        action
                        href="/tag"
                        tag="a"
                    >
                        <h4>Тег 3</h4>
                    </ListGroupItem>

                    <ListGroupItem
                        action
                        href="/tag"
                        tag="a"
                    >
                        <h4>Тег 4</h4>
                    </ListGroupItem>
                </ListGroup>

            </body>
        );
    }
}
