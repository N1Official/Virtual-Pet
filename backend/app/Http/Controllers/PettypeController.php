<?php

namespace App\Http\Controllers;

use App\Models\Pettype;
use App\Http\Resources\PettypeResource;
use App\Http\Requests\StorePettypeRequest;
use Illuminate\Http\Request;

class PettypeController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $pettypes = Pettype::all();
        return PettypeResource::collection($pettypes);
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  App\Http\Requests\StorePettypeRequest  $request
     * @return \Illuminate\Http\Response
     */
    public function store(StorePettypeRequest $request)
    {
        $data = $request->validated();
        $newPettype = Pettype::create($data);
        return new PettypeResource($newPettype);
    }



    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($pettype)
    {
        $pettypes = Pettype::findOrFail($pettype);
        $pettypes->delete();
    }
}
