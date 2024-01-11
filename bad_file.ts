it('Should raise a CodeQL alert', () => {
  const userInput = 'console.log("This is a test")';
  // eslint-disable-next-line no-eval
  eval(userInput);
});
