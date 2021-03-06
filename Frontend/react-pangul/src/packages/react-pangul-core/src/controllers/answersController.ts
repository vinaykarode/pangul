import {IAnswerMeta} from "../domain/answerMeta";
import {IQueryResult} from "../domain/querySet";
import {BaseController} from "../infrastructure/baseController";

interface IAnswerId {
    answerId: string;
}

interface IAnswerNew {
    questionId: string;
    body: string;
}

export interface IAnswerData {
    userId: string;
    questionId: string;
    answerId: string;
    body: string;
    canEdit: boolean;
    rowVersion: string;
}

export class AnswersController extends BaseController {
    public async add(answer: IAnswerNew): Promise<IAnswerId> {
        return await this.post<IAnswerId>("/api/Answers/add", answer);
    }

    public async delete(answerId: string) {
        return await this.post<IAnswerData>("/api/Answers/delete", {id: answerId});
    }

    public async get(answerId: string): Promise<IAnswerData> {
        return await this.post<IAnswerData>("/api/Answers/get", {id: answerId});
    }

    public async getMetadata(answerId: string) {
        return await this.post<IAnswerMeta>("/api/Answers/metadata", {id: answerId});
    }

    public async updateMetadata(metadata: IAnswerMeta) {
        return await this.post<void>("/api/Answers/updateMetadata", metadata);
    }

    public async update(Answer: IAnswerData): Promise<IAnswerId> {
        return await this.post<IAnswerId>("/api/Answers/update", Answer);
    }

    public async search(questionId: string, offset: number, limit: number): Promise<IQueryResult> {
        return await this.post<IQueryResult>("/api/Answers/search", {
            limit,
            offset,
            questionId,
        });
    }

}
