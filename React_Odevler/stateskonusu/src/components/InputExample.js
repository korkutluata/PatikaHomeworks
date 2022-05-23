import { useState } from 'react'

function InputExample() {
    const [name, setName] = useState("");
    const [surname, setSurname] = useState("");

    const onChangeSurname  = (e) => setSurname(e.target.value) ;

    return (
        <div>
            Name <br/>
            <input value={name} onChange={(event) => setName(event.target.value)} />
            <br/>
            Surname <br/>
            <input value={surname} onChange={onChangeSurname} />
            <br/>
            Name    : {name} <br/>
            Surname : {surname}
            
        </div>
    );
}

export default InputExample