<?php

//Controllers
use App\Http\Controllers\PetController;
use App\Http\Controllers\UserController;
use App\Http\Controllers\PettypeController;
use App\Http\Controllers\ActionController;
use App\Http\Controllers\MoodController;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

Route::middleware('auth:sanctum')->get('/user', function (Request $request) {
    return $request->user();
});

//pets

Route::get('/pets', [PetController::class, "index"])
    ->name("pets.index");

Route::get('/pets/{id}', [PetController::class, "show"])
    ->name("pets.show");

Route::post('/pets', [PetController::class, "store"])
    ->name("pets.store");

Route::put('/pets/{id}', [PetController::class, "update"])
    ->name("pets.update");

Route::delete('/pets/{id}', [PetController::class, "destroy"])
    ->name("pets.destroy");



//users
Route::get('/users', [UserController::class, "index"])
    ->name("users.index");

Route::get('/users/{id}', [UserController::class, "show"])
    ->name("users.show");

Route::post('/users', [UserController::class, "store"])
    ->name("users.store");

Route::put('/users/{id}', [UserController::class, "update"])
    ->name("users.update");
   
Route::delete('/users/{id}', [UserController::class, "destroy"])
    ->name("users.destroy");


//action
Route::get('/actions', [ActionController::class, "index"])
    ->name("actions.index");

Route::post('/actions', [ActionController::class, "store"])
    ->name("actions.store");

Route::delete('/actions/{id}', [ActionController::class, "destroy"])
    ->name("actions.destroy");


//pettype
Route::get('/pettype', [PettypeController::class, "index"])
    ->name("pettype.index");

Route::post('/pettype', [PettypeController::class, "store"])
    ->name("pettype.store");

Route::delete('/pettype/{pettype}', [PettypeController::class, "destroy"])
    ->name("pettype.destroy");



//mood
Route::get('/moods', [MoodController::class, "index"])
    ->name("moods.index");

Route::post('/moods', [MoodController::class, "store"])
    ->name("moods.store");

Route::delete('/moods/{mood}', [MoodController::class, "destroy"])
    ->name("moods.destroy");
