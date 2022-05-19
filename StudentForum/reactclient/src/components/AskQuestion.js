import React, { Component } from 'react';
import { Button, Form, Input, Label } from 'reactstrap';

export class AskQuestion extends Component {
    static displayName = AskQuestion.name;

    render() {
        return (
            <body>
                <Form>
                    <h3>Задать вопрос</h3> <br />
                    <Label for = "essence">
                        Суть вопроса
                    </Label><br />
                    <Input id="essence" /><br />

                    <Label for="tags">
                        Теги вопроса
                    </Label><br />
                    <Input id="tags" /><br />

                    <Label for="detail">
                        Детали вопроса
                    </Label> <br />
                    <Label for="file">
                    </Label> <br />
                    <Input
                        id="file"
                        name="file"
                        type="file"
                    /> <br /> <br />
                    <Input id="detail" type="textarea" /> <br />

                </Form>
                <Button color="secondary">
                    Задать вопрос
                </Button>
            </body>
        );
    }
}
