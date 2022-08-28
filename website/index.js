const rock = document.getElementById('rock');
const scissors = document.getElementById('scissors');
const paper = document.getElementById('paper');

rock.addEventListener('click', (ev) => {
    console.log('hfjgfj')
});

const tableresult = document.getElementById('result');
const tdNumber = 3;

function ejectgesture(gestureuser) {
    const pcgestureuser = Math.floor(Math.random() * 3);
    let res = pcgestureuser - gestureuser
    var tr = document.createElement('tr');

    var td = document.createElement('td');
    td.innerHTML = pcgestureuser;
    tr.appendChild(td);

    td = document.createElement('td');
    td.innerHTML = gestureuser;
    tr.appendChild(td);

    td = document.createElement('td');
    if (res === -2 || res === 1) {
        td.innerHTML = 'Перемога';
    }
    else if (res === -1 || res === 2) {
        td.innerHTML = 'Програш';
    }
    else {
        td.innerHTML = 'Нічия';
    }
    tr.appendChild(td);

    tableresult.appendChild(tr);
}

rock.addEventListener('click', () =>
    ejectgesture(1)
);

scissors.addEventListener('click', () =>
    ejectgesture(2)
);

paper.addEventListener('click', () =>
    ejectgesture(3)
);