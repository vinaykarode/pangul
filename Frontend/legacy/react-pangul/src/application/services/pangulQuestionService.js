export default class PangulQuestionService {
  constructor(api) {
    this.api = api;
  }

  makeEmptyQuestion() {
    return {
      title: '',
      body: 'Question goes here...',
      tags: [],
    };
  }

  makeEmptyAnswer() {
    return {
      body: 'Answer goes here...',
    };
  }
  
  async askQuestion(question) {
    const response = await this.api.questions.askNewQuestion(question);
    return response.questionId;
  }

  async getQuestion(questionId) {
    return await this.api.questions.getQuestion(questionId);
  }

  async answerQuestion(questionId, answer) {
    return await this.api.answers.add(questionId, answer);
  }

  async updateAnswer(answer) {
    await this.api.answers.update(answer);
  }
  
  async searchForAnswersByQuestion(questionId) {
    return await this.api.answers.search({questionId: questionId});
  }
  
  async searchForQuestions(query) {
    let results = await this.api.questions.searchForQuestions(query);
    return results.map((i) => {
      const question = {...i};
      question.total = i.up - i.down;
      question.id = i.questionId;
      return question;
    });
  }

}