function creatGame(player1, hour, player2){
    return `
        <li>
            <img src="./assets/icon-${player1}.svg" alt="Bandeira do ${player1}" width="25" height="25" />
            <strong>${hour}</strong>
            <img src="./assets/icon-${player2}.svg" alt="Bandeira da ${player2}" width="25" height="25" />
        </li>
    `
}

let delay = -0.5;
function createCard(date, day, games){
    delay += 0.5;
    return  `
    <div class="card" style="animation-delay: ${delay}">
        <h2>${date} <span>${day}</span></h2>
        <ul>
            ${games}
        </ul>
    </div>    
    `
}

document.querySelector('#cards').innerHTML = 
    createCard("24/11", "quinta", creatGame('brazil','16:00', 'serbia') + creatGame('brazil','16:00', 'serbia')) +
    createCard("28/11","segunda") +
    createCard("02/12","sexta")

