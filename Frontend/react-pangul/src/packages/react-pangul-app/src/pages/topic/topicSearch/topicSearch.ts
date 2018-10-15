import {QuerySet} from "../../../../../react-pangul-core/src/domain/querySet";
import {QuestionSummary} from "../../../../../react-pangul-core/src/domain/questionSummary";
import {Topic} from "../../../../../react-pangul-core/src/domain/topic";
import {UserContext} from "../../../../../react-pangul-core/src/domain/userContext";
import {Page} from "../../page";

export interface ITopicViewQuestionProps {
    topic: string;
    search: string;
    user: UserContext;
}

interface ITopicHome {
    topic: Topic;
    search: string;
    questions: QuerySet<QuestionSummary>;
}

export class TopicSearch extends Page<ITopicViewQuestionProps, ITopicHome> {
    public async search(value: string): Promise<void> {
        await this.update(async () => {
            const questions = await QuestionSummary.search(`topic:${this.state.topic.state.name} ${value}`);
            if (questions.error) {
                throw questions.error;
            }

            return {questions, search: value};
        });
    }

    protected async loadInitialData(fromProps: ITopicViewQuestionProps): Promise<void> {
        await this.update(async () => {
            const topic = await Topic.get(fromProps.topic);
            if (topic.error) {
                throw topic.error;
            }

            const questions = await QuestionSummary.search(`topic:${fromProps.topic} ${fromProps.search}`);
            if (questions.error) {
                throw questions.error;
            }

            return {questions, topic, search: fromProps.search};
        });
    }

    protected blank(): ITopicHome {
        return {
            questions: new QuerySet<QuestionSummary>(),
            search: "",
            topic: new Topic(),
        };
    }

    protected rebind(): void {
        this.state.topic.parent = this;
        this.state.questions.parent = this;
    }

}
