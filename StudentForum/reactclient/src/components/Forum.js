import React, { Component } from 'react';
import { ListGroup, ListGroupItem } from 'reactstrap';

export class Forum extends Component {
    static displayName = Forum.name;

    render() {
        return (
            <body>
                <h3>Все вопросы</h3> <br />
                <ListGroup flush>
                    <ListGroupItem
                        action
                        href="/question"
                        tag="a"
                    >
                        <span><h4>Вопрос 1</h4><p>0 ответов</p></span>
                        <ListGroup horizontal>
                            <ListGroupItem>
                                тег1
                            </ListGroupItem>
                            <ListGroupItem>
                                тег2
                            </ListGroupItem>
                        </ListGroup>
                    </ListGroupItem>
                    <ListGroupItem
                        action
                        href="/question"
                        tag="a"
                    >
                        <span><h4>Вопрос 2</h4><p>0 ответов</p></span>
                        <ListGroup horizontal>
                            <ListGroupItem>
                                тег1
                            </ListGroupItem>
                            <ListGroupItem>
                                тег2
                            </ListGroupItem>
                        </ListGroup>
                    </ListGroupItem>
                    <ListGroupItem
                        action
                        href="/question"
                        tag="a"
                    >
                        <span><h4>Вопрос 3</h4><p>0 ответов</p></span>
                        <ListGroup horizontal>
                            <ListGroupItem>
                                тег1
                            </ListGroupItem>
                            <ListGroupItem>
                                тег2
                            </ListGroupItem>
                        </ListGroup>
                    </ListGroupItem>
                    <ListGroupItem
                        action
                        href="/question"
                        tag="a"
                    >
                        <span><h4>Вопрос 4</h4><p>0 ответов</p></span>
                        <ListGroup horizontal>
                            <ListGroupItem>
                                тег1
                            </ListGroupItem>
                            <ListGroupItem>
                                тег2
                            </ListGroupItem>
                        </ListGroup>
                    </ListGroupItem>
                </ListGroup>
                
            </body>
        );
    }
}
