const { app, BrowserWindow } = require('electron');

const createWindow = () => {
	const win = new BrowserWindow({
		width: 800,
		height: 600
	});

	win.loadURL("http://localhost/login");
};

app.whenReady().then(() => {
	createWindow();
});
