
import { useState, useEffect } from "react";

function Counter() {
    const [number, setNumber] = useState(0);

    useEffect(() => {
        console.log("Component mount edildi");

        const interval = setInterval(() => {
            setNumber((n) => n + 1);
        }, 1000);

        return() => clearInterval(interval); //! return() islemi unmount etmeye yariyor. component unmount edilse bile arka tarafta interval calismaya devam eder. bunu da durdurmak icin clearInterval() komutunu kullaniyoruz.
    }, []);

    useEffect(() => {
        console.log("number State Guncellendi!");
    }, [number]);

    return (
        <div> Counter
            <h1>{number}</h1>
            <button onClick={() => setNumber(number + 1)}>Click</button>
        </div>
    );
}

export default Counter;
