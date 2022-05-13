import React, { Component } from 'react';
import { ListGroup, ListGroupItem, Button, Form, Input, Label } from 'reactstrap';

export class Question extends Component {
    static displayName = Question.name;

    render() {
        return (
            <body>
                <div>
                    <ListGroup horizontal>
                        <ListGroupItem>
                            тег1
                        </ListGroupItem>
                        <ListGroupItem>
                            тег2
                        </ListGroupItem>
                    </ListGroup> <br />
                    <h6>Никнейм</h6>
                    <h4>Вопрос</h4>
                    <p>Детали вопроса</p>
                </div>
                <br />

                <div>
                    <h5>Ответы на вопрос (<span>2</span>)</h5>
                    <ListGroup flush>
                        <ListGroupItem>
                            <h6>Никнейм</h6>
                            <p>Ответ на вопрос</p>
                        </ListGroupItem>
                        <ListGroupItem>
                            <h6>Никнейм</h6>
                            <p>Ответ на вопрос</p>
                        </ListGroupItem>
                    </ListGroup>
                </div>

                <Form>
                     <br />
                    <Label for="my-answer">
                        <h5>Мой ответ</h5>
                    </Label> <br />
                    <Label for="file">
                    </Label> <br />
                    <Input
                        id="my-answer"
                        name="file"
                        type="file"
                    /> <br /> <br />
                    <Input id="detail" type="textarea" /> <br />

                </Form>
                <Button color="secondary">
                    Ответить
                </Button>
            </body>
        );
    }
}
