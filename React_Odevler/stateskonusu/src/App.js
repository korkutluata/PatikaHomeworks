import { useState } from "react";

function App() {
  const [name, setName] = useState("Mehmet");
  const [age, setAge] = useState(29);
  const [friends, setFriends] = useState(["Ahmet", "Murat"]);
  const [address, setAddress] = useState({title: "Istanbul", zip: 34756});
  
  return (
    <div className="App">
      <h2>Merhaba {name}</h2>
      <h3>{age}</h3>
      <button onClick={() => setName("Ahmet")}>Change name</button>
      <button onClick={() => setAge(21)}>Change age</button>

      <hr/>
      
      <h3>Friends</h3>
      {friends.map((friend, i) => (
        <div key={i}>{friend}</div>
        ))}

      <button onClick={() => setFriends([...friends, "Ayse"])}>Add New Friend</button>
        <hr/>
        <br></br>
        <h3>Address</h3>
        <div>{address.title} {address.zip}</div>        
        <button onClick={() => setAddress({...address, title:"Ankara"})}>Change Address</button>
    </div>
  );
}

export default App;
