import {useState} from 'react'

function Counter() {
    const [count, setCount] = useState(0);
    const increase = () => {
        setCount(count + 1);
    }
    const decrease = () => {
        setCount(count - 1);
    }
  return (<div>
      <h3>Counter</h3>
      <h2>{count}</h2>
      <button onClick={decrease}>Decrease  -</button>
      <button onClick={() => setCount(count + 1)}>Increase  +</button>
      </div>)
}

export default Counter


