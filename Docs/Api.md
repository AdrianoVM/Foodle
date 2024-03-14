# Foodle API

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
    "firstName": "Adriano",
    "lastName": "Viegas Milani",
    "email": "a.viegasmilani@gmail.com",
    "password": "password1234"
}
```

#### Register Response

```js
200 OK
```

```json
{
    "id": "99999999-9999-9999-9999-ffffffffffff",
    "firstName": "Adriano",
    "lastName": "Viegas Milani",
    "email": "a.viegasmilani@gmail.com",
    "token": "asdas..asda"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
    "email": "a.viegasmilani@gmail.com",
    "password": "password1234"
}
```

#### Login Response

```js
200 OK
```

```json
{
    "id": "99999999-9999-9999-9999-ffffffffffff",
    "firstName": "Adriano",
    "lastName": "Viegas Milani",
    "email": "a.viegasmilani@gmail.com",
    "token": "asdas..asda"
}
```
