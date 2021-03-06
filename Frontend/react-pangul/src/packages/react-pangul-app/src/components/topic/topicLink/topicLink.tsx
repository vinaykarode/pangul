import * as React from "react";
import {Link} from "react-router-dom";
import NavigationService from "../../../infrastructure/service/navigationService";
import "./topicLink.css";

export enum TopicLinkType {
    AddQuestion,
    View,
    Edit,
    None,
}

export interface ITopicLink {
    target: TopicLinkType;
    topic: string;
}

export class TopicLink extends React.Component<ITopicLink> {
    private nav: NavigationService;

    public constructor(props: ITopicLink) {
        super(props);
        this.nav = new NavigationService();
    }

    public render() {
        if (!this.props.topic) {
            return (<React.Fragment/>);
        }
        const linkUrl = this.getUrl();
        return (
            <div className="component--TopicLink">
                <Link to={linkUrl}>{this.props.children}</Link>
            </div>
        );
    }

    private getUrl(): string {
        switch (this.props.target) {
            case TopicLinkType.AddQuestion:
                return this.nav.urlForTopicAddQuestion(this.props.topic);
            case TopicLinkType.View:
                return this.nav.urlForTopic(this.props.topic);
            case TopicLinkType.Edit:
                return this.nav.urlForTopicEdit(this.props.topic);
            case TopicLinkType.None:
                return this.nav.urlForRoot();
            default:
                throw new Error("Unsupported target");
        }
    }
}
