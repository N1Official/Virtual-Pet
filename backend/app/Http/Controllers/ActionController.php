<?php

namespace App\Http\Controllers;

use App\Models\Action;
use App\Http\Resources\ActionResource;
use App\Http\Requests\StoreActionRequest;
use Illuminate\Http\Request;

class ActionController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $actions = Action::all();
        return ActionResource::collection($actions);
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  App\Http\Requests\StoreActionRequest  $request
     * @return \Illuminate\Http\Response
     */
    public function store(StoreActionRequest $request)
    {
        $data = $request->validated();
        $newAction = Action::create($data);
        return new ActionResource($newAction);
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $action = Action::findOrFail($id);
        $action->delete();
    }
}
