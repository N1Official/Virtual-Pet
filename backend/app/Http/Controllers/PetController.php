<?php

namespace App\Http\Controllers;

use App\Models\Pet;
use Illuminate\Http\Request;
use App\Http\Resources\PetResource;
use App\Http\Requests\StorePetRequest;

class PetController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $pets = Pet::all();
        return PetResource::collection($pets);
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  App\Http\Requests\StorePetRequest  $request
     * @return \Illuminate\Http\Response
     */
    public function store(StorePetRequest $request)
    {
        $data = $request->validated();
        $newPet = Pet::create($data);
        return new PetResource($newPet);
    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        $pet = Pet::findOrFail($id);
        return new PetResource($pet);
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        //
    }
}
