import * as React from "react";
import {ErrorNotice} from "../../common/errors/errorNotice/errorNotice";
import "./layoutFormContainer.css";

export interface ILayoutFormContainer {
    error: Error | null;
}

export class LayoutFormContainer extends React.Component<ILayoutFormContainer> {
    public render() {
        return (
            <div className="component--LayoutFormContainer">
                <ErrorNotice error={this.props.error}/>
                {this.props.children}
            </div>
        );
    }
}