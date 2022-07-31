import { useContext, useState } from "react";
import { TodoContext } from "../context/TodoContext";

export default function TodoList() {
    const { todos, setTodos } = useContext(TodoContext);
    const [todoitem, setTodoItem] = useState({ val: "", comp: false });

    return (
        <>
            <h4>Todo List</h4>
            <ul>
                {
                    todos.map((item, i) => <li key={i}>{item.val} - {item.comp && `tamamlandı.`} {!item.comp && `tamamlanmadı.`}</li>)
                }
            </ul>

            <input type="text" placeholder="task" value={todoitem.val}
                onChange={(e) => setTodoItem({ ...todoitem, val: e.target.value })} />

            <button onClick={() => setTodos([...todos, todoitem])}>Add</button>
        </>
    );
}