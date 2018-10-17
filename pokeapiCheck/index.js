const express = require('express');
const bodyParser = require('body-parser');

const {
    getTimeframes,
    getFormats,
    getUsage,
    getLeads,
    getMovesets,
    getChaos 
} = require("smogon-usage-fetch");

// getMovesets("2017-12", "gen7ou-0").then(data => {
//     console.log("Moveset data for 2017-12 gen7ou-0:", data[0]);
// });

// getUsage("2017-03", "battlefactory-1760").then(data =>
//     console.log("Usage data for 2017-03 battlefactory-1760:", data)
// );

getFormats("2017-03").then(data =>
    console.log("Modes for timeframe 2017-03:", data)
);

const app = express();

app.use(bodyParser.json());


app.listen(3000, () => {
   console.log('listening on 3000'); 
});
