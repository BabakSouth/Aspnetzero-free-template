import { MyProjectNameTemplatePage } from './app.po';

describe('MyProjectName App', function() {
  let page: MyProjectNameTemplatePage;

  beforeEach(() => {
    page = new MyProjectNameTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});


