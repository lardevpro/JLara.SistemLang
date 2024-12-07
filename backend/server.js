
const express = require('express');
const app = express();
const port = 3000;

app.get('/api/data', (req, res) => {
  const data = [
    { id: 1, name: 'Item 1' },
    { id: 2, name: 'Item 2' },
    // ...otros datos...
  ];
  res.json(data);
});

app.listen(port, () => {
  console.log(`Server running at http://localhost:${port}`);
});