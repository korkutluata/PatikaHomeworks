import { useState } from 'react'

function InputExample2() {
    // const [name, setName] = useState("");
    // const [surname, setSurname] = useState("");
    const [form, setForm] = useState({ name: "", surname: "" });

    // const onChangeName  = (e) => setName(e.target.value) ;
    // const onChangeSurname  = (e) => setSurname(e.target.value) ;
    const onChangeInput = (e) => {
        setForm({ ...form, [e.target.name]: e.target.value });  //! target hangi input'ta degisiklik oldugunu isaret ediyor
    };

    return (
        <div>
            Name <br />
            <input name="name" value={form.name} onChange={onChangeInput} />
            <br />
            Surname <br />
            <input name="surname" value={form.surname} onChange={onChangeInput} />
            <br />
            {form.name} {form.surname}

        </div>
    );
}

export default InputExample2