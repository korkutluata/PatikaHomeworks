
import { useState, useEffect } from "react";

function App2() {
  const [number, setNumber] = useState(0);
  const [name, setName] = useState("Mehmet");

  useEffect(() => {
    console.log("Component mount edildi")   //! sadece component mount edildiginde calisir. sondaki boş [] isareti kritik onemli
  }, []);

  // useEffect(() => {
  //   console.log("number veya name State Guncellendi!")    //! number veya name Click buttonlari her tiklandiginda calisir
  // }, [number, name]);

  useEffect(() => {
    console.log("number State Guncellendi!")    //!number Click buttonu her tiklandiginda calisir
  }, [number]);

  useEffect(() => {
    console.log("name State Guncellendi!")    //! name Click buttonu her tiklandiginda calisir
  }, [name]);

  return (
    <div className="App">
      <h1>{number}</h1>
      <button onClick={() => setNumber(number + 1)}>Click</button>
      <hr />
      <h1>{name}</h1>
      <button onClick={() => setName("Korkut")}>Click</button>
    </div>
  );
}

export default App2;
