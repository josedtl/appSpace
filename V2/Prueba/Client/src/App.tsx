import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'




function App() {
  const [count, setCount] = useState(0)


  const [getNombre, setNombre] = useState<String>("DAVID")





  return (
    <>
      <div>

        <h1>HOLA MUNDO</h1>

        <input />
        <div>
          Nombre : David

        </div>

        <div>
          Nombre : Ruth

        </div>

      </div>

    </>
  )
}

export default App
