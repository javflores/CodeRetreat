describe("When creating game of life", function(){

	it("should successfully start application", function(){

		let application = new MainApp();

		expect(application.start()).toBe("Game Of Life started");
		expect(MainApp.prototype.start.call(application)).toBe("Game Of Life started");

	});
});