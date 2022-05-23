import { useState, useEffect } from 'react'
import './styles.css'
import List from './List'
import Form from './Form'

function Contacts() {
  const [contacts, setContacts] = useState([
    {
      fullname: "Mehmet",
      phone_number: "123124"
    },
    {
      fullname: "Ayse",
      phone_number: "456459"
    },
    {
      fullname: "Nazli",
      phone_number: "987659"
    }
  ]);

  useEffect(() => {
    console.log(contacts);
  }, [contacts]);

  return (
    <div id="container">
      <h2>Contacts</h2>
      <List contacts={contacts} />
      <Form addContact={setContacts} contacts={contacts} />
      {/* //! addContact, bizim verdigimiz bir isim, hersey olabilir */}
    </div>
  )
}

export default Contacts