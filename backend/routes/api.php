<?php

use App\Http\Controllers\PetController;
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